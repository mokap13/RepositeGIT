using InstanceStrategyPattern.HealthRecovery;
using InstanceStrategyPattern.Strike;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceStrategyPattern.Monster
{
    abstract class MonsterBase
    {
        protected IStrike strikeBehiviour;
        protected IHealthRecovery recovBehiviour;

        public MonsterBase()
        {
            strikeBehiviour = new SimpleStrike();
            recovBehiviour = new SimpleHealthRecovery();
        }

        public virtual void Strike()
        {
            strikeBehiviour.Strike();
        }

        public virtual void HealthRecovery()
        {
            recovBehiviour.HealthRecovery();
        }

        public abstract void Display();
    }
}
