﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace N64Track
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
