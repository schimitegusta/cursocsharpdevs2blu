using Microsoft.AspNetCore.Identity;

namespace Devs2Blu.ProjetosAula.AtividadeConsumoApi.Models
{
    public class Agents
    {
        public List<ResultsAgents> data { get; set; }
        public class ResultsAgents
        {
            public string displayName { get; set; }
            public string displayIcon { get; set; }
            public string fullPortrait { get; set; }
        }
    }
}
