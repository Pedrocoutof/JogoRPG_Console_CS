public class Menu{
    public void upgradeMenu(Player player){
        
        int opcao;
        do{
            Console.WriteLine($@"
                            =============================
                            ==== MENU DE UPGRADE {player.getMoeda()}C ====
                            ===== 1 - 20C - +10 Vida ====
                            ===== 2 -15C - +5 Dano  =====
                            ===== 3 - Nenhum       ======
                            =============================");
            opcao = int.Parse(Console.ReadLine()!);

            if(opcao == 1){
                if(player.perdeMoeda(20)){
                    player.vidaUp();
                    Console.Clear();
                }
            }
            else if(opcao ==2){
                if(player.perdeMoeda(15)){
                    player.danoUp();
                    Console.Clear();
                }
            }
        }while(opcao != 3);

        Console.Clear();
    }

    public int movimentacao(Player player){

                    Console.WriteLine($@"
                            =============================
                            =    Moedas {player.getMoeda()}C = HP:{player.getVida()}    =
                            =====   1 - Esquerda    =====
                            =====   2 - Meio        =====
                            =====   3 - Direita     =====
                            =============================");
            return int.Parse(Console.ReadLine()!);
    }

    public void batalha(Player player, Inimigo inimigo){
        Console.WriteLine($"{player.getNome()} encontra um inimigo de nivel {inimigo.getDificuldade()}!");
        
        do{
            Console.WriteLine("\nVoce deseja batalhar?");
            Console.WriteLine("1 - Sim | 2 - Nao");
            int opcao = int.Parse(Console.ReadLine()!);

            if(opcao == 1){
                Console.WriteLine($"Player: {player.getVida()}HP  |  Inimigo: {inimigo.getVida()}HP");
                player.ataque(inimigo);
                inimigo.ataque(player);
            }
            else if(opcao == 2){
                Console.Clear();
                Console.WriteLine("Voce decide fugir!");
                return;
            }
        }while(player.estaVivo() && inimigo.estaVivo());

        if(!inimigo.estaVivo()){
            Console.Clear();
            Random random = new Random();
            int moedasGanhas = random.Next(25);
            player.ganhaMoeda(moedasGanhas);
            Console.WriteLine($"{player.getNome()} vence a batalha e ganha {moedasGanhas}C!");
            return;
        }else{
            Console.Clear();
            Console.WriteLine($"O player perdeu a batalha para um inimigo level {inimigo.getDificuldade()}");
            return;
        }

    }

}
