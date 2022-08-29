# ApiMediaTR-Gof-
O padrão MediaTR implantado em um projeto API tem como objetivo separar a camada de injeção de dependência do controlador, jogando diretamente para o método Handler (Processador).
É bem utilizado em projetos que possuem muitas injeções de dependência no controlador, e que nem todas são utilizadas por todos os métodos. 
