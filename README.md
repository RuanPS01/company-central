# company-central

Projeto em C# com interação via Terminal. 
### Implementado no Visual Studio Community
___
Esse projeto possui as seguintes **classes de entidades**:
 - Address - (classe para guardar endereço de um funcionário ou outra entidade)
 - Benefit - (classe para guardar os benefícios que a empresa disponibiliza para um funcionário)
 - Department - (classe para guardar os departamentos da empresa)
 - EmergencyContact - (classe para guardar os dados de um contato de epergência de um funcionário)
 - Employee - (classe para guardar os dados de um funcionário)
 - PersonalData - (classe para guardar os dados pessoais de um funcionário)
 - Position - (classe para guardar o cargo de um funcionário)
 - Vacation - (classe para guardar os dados sobre as férias de um funcionário)
 - WarehouseItem - (classe para guardar os dados item de almoxarifado)
 - WorkResource - (classe para guardar os dados de recursos de trabalho em uso por um funcioinário)
___
Esse projeto possui as seguintes **classes abstratas**:
- ResponseCrudAction - (classe para padronização de retorno de métodos)
- UniqueRegistry - (classe para padronização do uso de um identificador único)
___
Esse projeto possui as seguintes **interfaces**:
- ICrudActions - (interface para padronização de ações de um CRUD para classes de entidade)
___
Nesse projeto também foi criado um sistema de banco de dados falso, simulando repositórios de manipulação de cada tabela possível que seria gerada pelas entidades. Cada Repository possui os métodos Save, Update, Find, FindOne e Delete que manipulam um List independende cada, que vai ser mantido na instâcia que for criada do Repository. Esses métodos do Repository são chamados em cada entidade para a manipulação daquela entidade, em questão, para o banco.

Espero que goste!

Att.
Ruan Patrick de Souza 
