import Table from 'react-bootstrap/Table';

function TabelaGrupo({ ListaGrupo }) {
    return (
        <div>
            <Table className="col-3">
                <thead>
                    <tr>
                        <th>C�digo Grupo</th>
                        <th>Nome do Grupo</th>
                    </tr>
                </thead>
                <tbody>
                    {ListaGrupo?.map((Grupo) => (
                        <tr key={Grupo.id}> {/* 'key' �nico por item */}
                            <td>{Grupo.id}</td> {/* Corrigido o campo */}
                            <td>{Grupo.Nome}</td> {/* Corrigido o campo */}
                        </tr>
                    ))}
                </tbody>
            </Table>
        </div>
    );
}
export default TabelaGrupo;