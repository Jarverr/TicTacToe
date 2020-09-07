using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class PlayerResults:DbContext
    {
        public DbSet<Player> GamesResult { get; set; }
    }
}
