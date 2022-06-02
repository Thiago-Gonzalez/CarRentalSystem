# Exercise_Interface_CarRentalSystem
<p>Simples sistema de aluguel de carros implementado como prática dos conceitos de Orientação a Objetos e Interface, disponível versões com implementação com e sem o uso
  de Interface.</p>
<p>Problema exemplo: Uma locadora brasileira de carros cobra um valor por hora para locações de até 12 horas. 
  Porém, se a duração da locação ultrapassar 12 horas, a locação será cobrada com base em um valor diário. Além do valor da locação, é acrescido no preço o valor do
  importo conforme regras do país que, no caso do Brasil, é 20% para valores até R$100,00, ou 15% para valores acima de R$100,00. 
  Fazer um programa que lê os dados da locação (modelo do carro, instante inicial e final da locação), bem como o valor por hora e o valor diário de locação. 
  O programa deve então gerar a nota de pagamento (contendo valor da locação, valor do importo e valor total do pagamento) e informar os dados na tela.</p>
  <p>A diferença entre ambas as versões consistem em que na primeira versão, sem a implementação da Interface, a classe RentalService ficava completamente dependente
de BrazilTaxService, e, em caso de necessidade de alteração do provedor desse serviço de taxa, seria necessário alterar o código em dois pontos: a implementação do novo
provedor de serviço de taxa e alterar também na classe RentalService, o que dificulta a manutenção do código. Já com a utilização de Interface, que vai ser um provedor
genérico do serviço de taxa (ITaxService), que implementa o método de Tax, e trocando a dependência na classe RentalService para ITaxService, é feita a inversão de 
controle por meio da injeção de dependência (um dos princípios SOLID), e, dessa forma, RentalService passa a depender de um provedor genérico do serviço, e, em caso de alteração
do provedor, é necessário agora implementar somente a classe do novo provedor sendo essa um subtipo de ITaxService que implementa o método Tax.</p>

![image](https://user-images.githubusercontent.com/80121288/171543319-b686d25d-99ff-4065-adbf-6cad277746ea.png)

![image](https://user-images.githubusercontent.com/80121288/171543084-9f0abe7a-e3dd-4437-8832-649cdaac28e5.png)
