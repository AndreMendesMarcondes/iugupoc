using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IUGU.Web.Models
{
    public class ItemRequest
    {
        public string description { get; set; }
        public int quantity { get; set; }
        public int price_cents { get; set; }
    }

    public class Payer
    {
        public string cpf_cnpj { get; set; }
        public string name { get; set; }
    }

    public class IUGURequest
    {
        public bool ensure_workday_due_date { get; set; }
        public List<ItemRequest> items { get; set; }
        public List<string> payable_with { get; set; }
        public Payer payer { get; set; }
        public string email { get; set; }
        public string due_date { get; set; }

        public IUGURequest(int valor)
        {
            items = new List<ItemRequest>();
            payable_with = new List<string>();
            payer = new Payer();

            items.Add(new ItemRequest()
            {
                description = "teste",
                quantity = 1,
                price_cents = valor
            });

            payable_with.Add("pix");
            payer.name = "Teste Poc";
            email = "teste@teste.com";
            due_date = DateTime.Now.ToString("yyyy-MM-dd");
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
