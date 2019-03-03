using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packman.GameClasses
{
    public abstract class Packman : GameCreature
    {
        protected bool IsMouthClosed = false;

        public Packman(Position position) : base(position)
        {
            this.Direction = Direction.RIGHT;
            Life = 1;
        }

        public int Life { get; internal set; }

        public override void DoLoop()
        {
            IsMouthClosed = !IsMouthClosed;
        }
    }
}
