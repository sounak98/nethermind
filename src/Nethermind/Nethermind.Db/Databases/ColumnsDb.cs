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

using System.Collections.Generic;
using Nethermind.Db.Config;
using Nethermind.Logging;
using Nethermind.Store;

namespace Nethermind.Db.Databases
{
    public abstract class ColumnsDb<T> : DbOnTheRocks, IColumnsDb<T>
    {
        private readonly IDictionary<T, IDb> _columnDbs = new Dictionary<T, IDb>();
        
        protected ColumnsDb(string basePath, string dbPath, IDbConfig dbConfig, ILogManager logManager = null) : base(basePath, dbPath, dbConfig, logManager)
        {
        }
        
        public IDb GetColumnDb(T key)
        {
            if (!_columnDbs.TryGetValue(key, out var db))
            {
                _columnDbs[key] = db = new ColumnDb(Db, this, key.ToString());
            }

            return db;
        }
    }
}