# PROJETO BOLO # *

 # O que é ?

 *O  Projeto Bolo consiste em pegar um conjunto de nomes e definir uma data pra cada um, que seria o dia de trazer o Bolo, pelo responsável do dia.*

 # Camadas 
 
 # BoloProject.Domain
 
 // separação da camada dominio, que cria a classe abstrata Bolo entidade onde consta somente assinatura de atributos a serem 
 manipulados em outras camadas de processos, ou seja, essa camada irá ser uma dependência para outras camadas.
 
 # BoloProject.Processors

// camada onde é construida todas as implementações para o funcionamento do bolo, onde esta a ordenaçao do Nomes, definição das datas, e a leitura do arquivo . 

 # BoloProject 
 
// Bloco onde ocorre a execução do Bolo, separado dentro da pasta Initialize.  
