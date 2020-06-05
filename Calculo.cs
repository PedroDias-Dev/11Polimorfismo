namespace Polimorfismo_2
{
    public class Calculo
    {
        public string CalcularVida(){
            return "Nao ha nenhum calculo para ser aplicado.";
        }

        public string CalcularVida(int vida){
            return "A vida do jogador esta em " +vida;
        }

        public string CalcularVida(int vida, int escudo){
            return "A vida do jogador com escudo esta em " + (vida + escudo);
        }

        public string Calcular(string nome , string sobrenome){
            return $"O nome completo do jogador é {nome} {sobrenome}";
        }
    }
}