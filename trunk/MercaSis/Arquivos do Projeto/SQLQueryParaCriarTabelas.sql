create table Cliente(
cli_codigo int identity(1,1) not null,
cli_nome varchar(255) not null,
cli_cpfCnpj varchar(14) not null,
cli_sexo varchar(1) not null,
cli_dataNascimento datetime not null,
cli_dataCadastro datetime not null,
cli_telefone varchar(255) not null,
cli_telefoneSec varchar(255),
cli_email varchar(255) not null,
cli_senha varchar(255) not null,
cli_endereco varchar(255) not null,
cli_numero int not null,
cli_complemento varchar(255),
cli_cep varchar(8) not null,
cli_bairro varchar(255) not null,
cli_cidade varchar(255) not null,
cli_estado varchar(2) not null,
cli_apelido varchar(255),
primary key (cli_codigo)
)

create table Produto(
pro_codigo int identity(1,1) not null,
pro_nome varchar(255) not null,
pro_preco float not null,
pro_qtd_estoque int not null,
pro_peso float,
pro_categoria_codigo int not null,
pro_descricao varchar(255),
pro_imagem varchar(255),
primary key (pro_codigo)
)

create table Categoria(
cat_codigo int not null,
cat_nome varchar(255) not null,
primary key (cat_codigo)
)

create table Pedido(
ped_codigo int identity(1,1) not null,
ped_codigo_cliente int not null,
ped_codigo_items int not null,
ped_endereco_entrega varchar(255) not null,
ped_numero_entrega varchar(255) not null,
ped_bairro_entrega varchar(255) not null,
ped_comp_entrega varchar(255),
ped_cidade_entrega varchar(255) not null,
ped_estado_entrega varchar(255) not null,
ped_cep_entrega varchar(255) not null,
ped_preco_liq float not null,
ped_preco_frete float not null,
ped_preco_total float not null,
ped_forma_pagto varchar(255) not null,
ped_situacao varchar(255) not null,
ped_data_pedido datetime not null,
ped_data_entrega datetime not null,
primary key (ped_codigo),
foreign key (ped_codigo_cliente) references Cliente
)

create table ItemPedido(
ipe_codigo_pedido int not null,
ipe_codigo_produto int not null,
ipe_preco float not null,
foreign key (ipe_codigo_pedido) references Pedido,
foreign key (ipe_codigo_produto) references Produto
)

create table CustoFrete(
cfr_codigo int identity(1,1) not null,
cfr_preco float not null,
primary key (cfr_codigo)
)

create table CustoRegiao(
cre_codigo int identity(1,1) not null,
cre_regiao varchar(2) not null,
cre_preco float not null,
primary key (cre_codigo)
)