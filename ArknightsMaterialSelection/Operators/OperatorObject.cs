using ArknightsMaterialSelection.Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArknightsMaterialSelection
{
    internal class OperatorObject
    {
        string? OperatorName { get; set; }
        string? OperatorFaction { get; set; }
        List<SkillObject> Skills { get; set; }
    }
}
