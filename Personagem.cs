public abstract class Personagem{
    protected string nome { get; set; }
    protected int vida { get; set; }
    protected int dano {get; set; }
    protected bool flagVivo {set; get; }
    public Personagem(string nome, int vida = 100, int dano = 10){
        this.nome = nome;
        this.vida = vida;
        this.dano = dano;
        flagVivo = true;
    }
    public void ataque(Personagem personagem){
        Random danoAleatorio = new Random();
        int danoTotal =  danoAleatorio.Next(this.dano);

        Console.WriteLine($"O personagem {this.nome} atacou {personagem.nome} e deu um dano de {danoTotal} !");

        personagem.sofreDano(danoTotal);
    }
    public void sofreDano(int danoRecebido){
        this.vida -= danoRecebido;

        if(this.vida <= 0){
            flagVivo = false; 
        }
    }
    public bool estaVivo(){
        return flagVivo;
    }
    public void getInfo(){
        Console.WriteLine($"{vida}");
    }
}