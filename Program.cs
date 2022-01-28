

public class Program{
        static void Main(){
        Player player = new Player("Pedro", 100, 10);
        Menu menu = new Menu();
        int rodada = 0;
        Random rand = new Random();
        rand.Next(8);
        

        do{
            rodada++;
            Inimigo inimigo = new Inimigo(rodada++);

            int opcao = menu.movimentacao(player);
            if(opcao == 1){
                if(rand.Next(5) == 1)
                    player.danoUp();
                
                else{
                    Console.Clear();
                    menu.batalha(player, inimigo);
                }
            } 
            if(opcao == 2){
                if(rand.Next(5) == 1)
                    menu.upgradeMenu(player);

                else{
                    Console.Clear();
                    menu.batalha(player, inimigo);
                }
            }
            if(opcao == 3){
                if(rand.Next(5) == 1)
                    menu.upgradeMenu(player);
                
                else{
                    Console.Clear();
                    menu.batalha(player, inimigo);
                }
            }
        }while(player.estaVivo());

    }
}
