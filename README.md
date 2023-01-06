# Desafio Projeto Do Bootcamp Pottencial .NET Developer

## Desafio Proposto

Modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma 
abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento,
possibilitando um maior reuso de código.

## Projeto Realizado

- Primeiro criou as classes: Iphone, Motorola, Nokia e Smartphone;
- Depois na classe Smartphone criou um construtor com as propriedades de: numero, modelo, imei e memoria;
- Nessa classe ainda criou os métodos:
 Ligar, ReceberLigacao, MostrarNumero, MostrarModelo e uma função abstrata de InstalarAplicativos
- Nas demais outras classes se utilizam da classe Smartphone pois é uma classe abstrata;
- Então no arquivo Program.cs chama essas classes e seus respectivos métodos, como no celular Nokia que vai 
ligar, instalar o app da cobrinha, mostrar o numero, inserir outro número e mostra-lo novamente e mostrar o modelo
do aparelho
- Isso pode acontecer para os tipos de celulares.

