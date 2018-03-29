﻿/*
 * Copyright (c) 2018 Demerzel Solutions Limited
 * This file is part of the Nethermind library.
 *
 * The Nethermind library is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * The Nethermind library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * along with the Nethermind. If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using Nethermind.Network.Rlpx.Handshake;

namespace Nethermind.Network
{
    public class MessageSerializationService : IMessageSerializationService
    {
        private readonly ConcurrentDictionary<RuntimeTypeHandle, object> _serializers = new ConcurrentDictionary<RuntimeTypeHandle, object>();

        public T Deserialize<T>(byte[] bytes) where T : MessageBase
        {
            IMessageSerializer<T> serializer = GetSerializer<T>();
            return serializer.Deserialize(bytes);
        }

        public void Register<T>(IMessageSerializer<T> messageSerializer) where T : MessageBase
        {
            _serializers[typeof(T).TypeHandle] = messageSerializer;
        }

        public byte[] Serialize<T>(T messageBase) where T : MessageBase
        {
            IMessageSerializer<T> serializer = GetSerializer<T>();
            return serializer.Serialize(messageBase);
        }

        private IMessageSerializer<T> GetSerializer<T>() where T : MessageBase
        {
            RuntimeTypeHandle typeHandle = typeof(T).TypeHandle;
            if (!_serializers.TryGetValue(typeHandle, out object serializerObject))
            {
                Type type = typeof(T);
                throw new InvalidOperationException($"No {nameof(IMessageSerializer<T>)} registered for {type.Name}.");
            }

            IMessageSerializer<T> serializer = serializerObject as IMessageSerializer<T>;
            Debug.Assert(serializer != null, $"Unexpected serializer type {serializerObject.GetType().Name} for {nameof(T)}");
            return serializer;
        }
    }
}