QueOperadora
============

QueOperadora é um sistema que segue regras dispostas pela ANATEL para padrões em distribuição de números
nas operadoras.
Baseado nessas regras é possível determinar a operadora de qualquer aparelho móvel que não esteja com a 
**portabilidade**.

Linguagens Disponíveis
-----------------------
* Python
* Javascript
* C#


Lista de Operadoras
-------------------
* Claro
* CTBC
* Oi
* Sercomtel
* TIM
* Vivo


Python
------

* **Importe a classe QueOperadora do módulo queoperadora.**  
`from queoperadora import QueOperadora as q`

* **Chame a função queOperadora fornecendo o DDD e o número do celular**
`q = q()`
`q.queOperadora("99 9999-9999")`

* **A função retornará a operadora ou "" caso não encontre nada**  
`'OI'`

* **Faça consultas via linha de comando**   
`python queoperadora.py 48 9999-9999`  
`python queoperadora.py --help`  


Javascript
----------

* **Importe os arquivos na sua página html**
`<script type="text/javascript" src="js/queoperadora.js"></script>`   

* **Em um novo arquivo javascript**
`var op = queOperadora(ddd,celular) //ddd="48", celular="9999-9999"`   


Bugs
-----
1. Números Fixos não são reconhecidos.
2. Números Móveis que aderiram a **portabilidade** não são reconhecidos.
3. Números da NEXTEL não são reconhecidos.

Créditos
--------
* Eduardo Orige [eduardo.orige@gmail.com](mailto:eduardo.orige@gmail.com "Email")
* Césare Cibien [cesa.cibien@gmail.com](mailto:cesa.cibien@gmail.com "Email")