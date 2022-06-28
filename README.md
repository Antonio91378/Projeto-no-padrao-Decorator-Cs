        Atualizando aplicacao utilizando o padrao de projeto Decorador,
    que busca manter classe menores e coesas, criando uma logica em que
    esses comportamentos sao unificados ou 'decorados'. Dessa forma
    e possivel criar comportamentos complicados a partir de comportamentos
    simples.
        A unica mudanca no codigo foi substituir a interface existente, que
    era herdada por classes menores, por uma classe abstrata, que carrega
    uma logica simples, que busca admitir comportamentos de outras classes
    filhas. Ademais, foi necessario implementar os construtores, derivados
    da classe pai, nas classes filhas.
