using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.FormFlow;
using System;

namespace MaratonaBots.Formulario
{
    [Serializable]
    [Template(TemplateUsage.NotUnderstood, "Desculpe não entendi \"{0}\".")]
    public class Pedido
    {
        public Salgadinhos Salgadinhos { get; set; }

        public Bebidas Bebidas { get; set; }

        public TipoEntrega TipoEntrega { get; set; }


        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Endereco { get; set; }

        public static IForm<Pedido> BuildForm()
        {
            var form = new FormBuilder<Pedido>();
            form.Configuration.DefaultPrompt.ChoiceStyle = ChoiceStyleOptions.Buttons;
            form.Message("Olá, seja bem vindo! Sera um prazer atende-lo!");
            form.OnCompletion(async (context, pedido) => {
                //Salvar na base de dados
                //Gerar pedido
                //Integrar com serviço xpto
                await context.PostAsync("Seu pedido de numero 11111 foi gerado e em instantes será entregue");
            });
            return form.Build();
        }


    }

    public enum TipoEntrega
    {
        RetirarNoLocal = 1,
        Motoboy
    }

    public enum Salgadinhos
    {
        Esfirra = 1,
        Quibe, 
        Coxinha
    }

    public enum Bebidas
    {
        Refrigerante = 1,
        Agua,
        Suco
    }

}