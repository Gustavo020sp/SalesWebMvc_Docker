Passo a Passo para Clonar e Executar a Aplicação SalesWebMvc_Docker

1. Criar um Diretório para Clonar a Aplicação
Abra o terminal (ou prompt de comando no Windows).
Navegue até o local onde deseja criar o novo diretório, utilizando o comando cd, por exemplo:
cd /caminho/do/local/desejado
Crie um novo diretório para a aplicação:
mkdir SalesWebMvc_Docker
Navegue até o diretório criado:
cd SalesWebMvc_Docker

2. Clonar o Repositório
Execute o comando para clonar o repositório:
git clone https://github.com/Gustavo020sp/SalesWebMvc_Docker .

3. Construir e Inicializar o Container Docker
No mesmo diretório, execute o comando para construir e iniciar o container Docker:
docker-compose up --build

4. Acessar a Aplicação
Após a construção e inicialização do container, abra o navegador web e digite localhost:8081 na barra de endereços.
Alternativamente, você pode acessar o link fornecido pelo Docker para acessar a aplicação.

