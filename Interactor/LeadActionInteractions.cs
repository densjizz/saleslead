using Entity.Activity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactor
{
    public class LeadActionInteractions
    {
        public LeadAction CreateLeadAction() {
            LeadAction action = new LeadAction();
            action.Status = ActionStatus.Pending;
            action.Description = "Unnamed action";
            return action;
        }
    }
}
