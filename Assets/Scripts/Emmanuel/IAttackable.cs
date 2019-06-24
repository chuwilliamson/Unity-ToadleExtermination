using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Emmanuel;

namespace Assets.Scripts.Emmanuel
{
    interface IAttackable
    {
        float Attack(Entity other);
    }
}
