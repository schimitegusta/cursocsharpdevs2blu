namespace Devs2Blu.ProjetosAula.AtividadeConsumoApi.Models
{
    public class Weapons
    {
        public List<ResultsAgents> data { get; set; }
        public class ResultsAgents
        {
            public string displayName { get; set; }
            public string displayIcon { get; set; }
        }
    }
}
