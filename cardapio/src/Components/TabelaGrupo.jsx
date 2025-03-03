import Table from 'react-bootstrap/Table';
import React, { useState, useEffect } from 'react';
import { getListaGrupo } from '../../Services/GrupoService.js'; // Importa a função do serviço

function TabelaGrupo() {
    const [listaGrupo, setListaGrupo] = useState([]);

    useEffect(() => {
        const fetchData = async () => {
            const data = await getListaGrupo(); // Chama a API
            console.log(data);
            setListaGrupo(data); // Atualiza o estado com os grupos recebidos
        };

        fetchData();
    }, []); // O array vazio [] garante que a API seja chamada apenas uma vez

    return (

        <div>
            <Table className="col-3">
                <thead>
                    <tr>
                        <th>Código Grupo</th>
                        <th>Nome do Grupo</th>
                    </tr>
                </thead>
                <tbody>
                    {listaGrupo?.map((Grupo) => (
                        <tr key={Grupo.id}> {/* 'key' único por item */}
                            <td>{Grupo.id}</td> {/* Corrigido o campo */}
                            <td>{Grupo.nome}</td> {/* Corrigido o campo */}
                        </tr>
                    ))}
                </tbody>
            </Table>
        </div>
    );
}
export default TabelaGrupo;