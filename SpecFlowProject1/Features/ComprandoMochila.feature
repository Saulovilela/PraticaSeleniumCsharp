Feature: Comprando Mochila

Scenario: Compra Mochila
Given que eu clique na mochila
When clicar em add ao carrinho
And clicar no carrinho
And clicar em checkout
And coloco os dados de nome sobrenome e cep
And clico em finalizar
Then terei feito com sucesso a compra
