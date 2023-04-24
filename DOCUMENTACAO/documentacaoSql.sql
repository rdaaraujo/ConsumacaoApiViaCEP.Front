-- SQL UTILIZADO DESAFIO DO CÓDIGO CRUD
-- CRIAÇÃO DA TABELA

-- CRIAÇÃO TABELA 
begin;
CREATE TABLE public.tabela_ceps (
	cep_str varchar(9),
	logradouro_str varchar(200),
	complemento_str varchar(200),
	bairro_str varchar(100),
	localidade_str varchar(55),
	uf_str varchar(2),
	ibge_int integer,
	gia_int integer,
	ddd_int integer,
	siafi_int integer,
	tstamp timestamp
);
COMMENT ON COLUMN public.tabela_ceps.cep_str IS 'Número do CEP';
COMMENT ON COLUMN public.tabela_ceps.logradouro_str IS 'Nome da Rua';
COMMENT ON COLUMN public.tabela_ceps.complemento_str IS 'Complemento Endereço';
COMMENT ON COLUMN public.tabela_ceps.bairro_str IS 'Bairro';
COMMENT ON COLUMN public.tabela_ceps.localidade_str IS 'Cidade';
COMMENT ON COLUMN public.tabela_ceps.uf_str IS 'Estado';
COMMENT ON COLUMN public.tabela_ceps.ibge_int IS 'Código do IBGE';
COMMENT ON COLUMN public.tabela_ceps.gia_int IS 'Guia de Informação e Apuração';
COMMENT ON COLUMN public.tabela_ceps.ddd_int IS 'Código DDD da área';
COMMENT ON COLUMN public.tabela_ceps.siafi_int IS 'Código do Sistema Integrado de Administração Financeira';
COMMENT ON COLUMN public.tabela_ceps.tstamp IS 'Timestamp da inserção';

------------------------------------------------------------------------------------------------------------------------------------------------

17012633
17525160
14095280

---------------------------

{
  "cep": "17012-633",
  "logradouro": "Rua Professor Durval Guedes de Azevedo",
  "complemento": "",
  "bairro": "Jardim Infante Dom Henrique",
  "localidade": "Bauru",
  "uf": "SP",
  "ibge": "3506003",
  "gia": "2094",
  "ddd": "14",
  "siafi": "6219"
}

---------------------------

{
  "cep": "17525-160",
  "logradouro": "Rua Doutor Próspero Cecilio Coimbra",
  "complemento": "",
  "bairro": "Jardim São Gabriel",
  "localidade": "Marília",
  "uf": "SP",
  "ibge": "3529005",
  "gia": "4388",
  "ddd": "14",
  "siafi": "6681"
}

---------------------------

{
  "cep": "17525-160",
  "logradouro": "Rua Antônio Fernandes Figueroa",
  "complemento": "",
  "bairro": "Parque Industrial Lagoinha",
  "localidade": "Ribeirão Preto",
  "uf": "SP",
  "ibge": "3543402",
  "gia": "5824",
  "ddd": "16",
  "siafi": "6969"
}