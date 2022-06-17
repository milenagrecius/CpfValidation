# CpfValidation


### Contexto

Com a necessidade de criar cadastros válidos de pessoas físicas precisamos criar algumas validações básicas para garantir que isso ocorra, uma das formas de realizar esta validação é exigindo o cadastro de CPF. Porém, necessitamos garantir que seja um valor válido, para isso podemos validar os dígitos verificadores seguindo a seguinte regra:

O número de CPF tem 9 algarismos e mais 2 dígitos verificadores, que são indicados após uma barra. Logo, um CPF tem 11 algarismos. O número do CPF é escrito na forma ABCDEFGHIJ/JK ou diretamente como ABCDEFGHIJK, onde os algarismos não podem ser todos iguais entre si. 

### Para testar:
Clone o repositório na sua máquina</br>
Abra o projeto no Visual Studio</br>
Defina CpfValidation.API como projeto de inicialização</br>
Execute a aplicação apertando F5</br>

<b> No Swagger você poderá testar a validação CPFs através da /api/Cpf</b></br>
<p>Try it out > "cpf" > Execute</p>

*Por se tratar de uma string, o cpf a ser validado deverá estar sempre entre aspas.* 


#### Resultado esperado:
 
 - Válido: retorna status code 200 com a mensagem "cpf válido"
 - Inválido: retorna status code 400 com a mensagem "cpf inválido"



### Para executar o projeto de testes:
Defina CpfValidation.Tests como projeto de inicialização</br>
Execute a aplicação apertando CTRL + R + A</br>
Obs: nos testes possuímos o cenário esperado e o cenário inválido. 
