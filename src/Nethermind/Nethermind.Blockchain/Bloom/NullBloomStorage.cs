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

using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Nethermind.Blockchain.Bloom
{
    public class NullBloomStorage : IBloomStorage
    {
        public static NullBloomStorage Instance { get; } = new NullBloomStorage();

        public int LevelMultiplier => 1;
        public int Levels => 1;
        public void Store(long blockNumber, Core.Bloom bloom) { }

        public IBloomEnumeration GetBlooms(long fromBlock, long toBlock)
        {
            return new NullBloomEnumerator();
        }

        public bool ContainsRange(in long fromBlockNumber, in long toBlockNumber) => false;

        private class NullBloomEnumerator : IBloomEnumeration
        {
            public IEnumerator<Core.Bloom> GetEnumerator() => Enumerable.Empty<Core.Bloom>().GetEnumerator();

            public bool TryGetBlockRange(out Range<long> blockRange)
            {
                blockRange = default;
                return false;
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}