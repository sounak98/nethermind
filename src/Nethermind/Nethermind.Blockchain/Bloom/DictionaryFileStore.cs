﻿//  Copyright (c) 2018 Demerzel Solutions Limited
//  This file is part of the Nethermind library.
// 
//  The Nethermind library is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  The Nethermind library is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU Lesser General Public License for more details.
// 
//  You should have received a copy of the GNU Lesser General Public License
//  along with the Nethermind. If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nethermind.Blockchain.Bloom;

namespace Nethermind.Blockchain.Test.Bloom
{
    public class DictionaryFileStore : IFileStore
    {
        IDictionary<long, byte[]> _store = new Dictionary<long, byte[]>();
            
        public ValueTask DisposeAsync()
        {
            _store.Clear();
            return default;
        }

        public void Dispose()
        {
            _store.Clear();
        }

        public void Write(long index, byte[] element)
        {
            _store[index] = element;
        }

        public int Read(long index, byte[] element)
        {
            if (_store.TryGetValue(index, out var found))
            {
                Array.Copy(found, element, found.Length);
                return found.Length;
            }

            return 0;
        }

        public IFileReader GetFileReader() => new DictionaryFileReader(this);

        public void Flush() { }
    }
}