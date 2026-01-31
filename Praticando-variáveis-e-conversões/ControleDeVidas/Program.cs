int vidas = 5;
Erro();
Acerto();
Fim();



void Erro(){
    setVidas(getVidas()-1);
    Console.WriteLine($"O jogador errou! Agora a quantidade de vidas é: {getVidas()}");
}

void Acerto()
{
    setVidas(getVidas()+1);
    Console.WriteLine($"O jogador acertou! Agora a quantidade de vidas é {getVidas()}");
}

void Fim()
{
    Console.WriteLine($"Fim de jogo. Vidas finais: {getVidas()}");
}
void setVidas(int qtd)
{
    vidas = qtd;
}
int getVidas()
{
    return vidas;
}

