# ApiMediaTR-Gof-
O padrão MediaTR implantado em um projeto API tem como objetivo separar a camada de injeção de dependência do controllador, jogando diretamente para o método Handler (Processador).
Tem como bom uso em projetos que possuem muitas importações no controller, e que nem todas são utilizadas por todos os métodos. 
