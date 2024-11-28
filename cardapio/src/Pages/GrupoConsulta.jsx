import TabelaGrupo from '../Components/TabelaGrupo.jsx'
import Row from 'react-bootstrap/Container';
const ListaGrupo = [
    { id: 1, Nome: "Administração" },
    { id: 2, Nome: "Financeiro" },
    { id: 3, Nome: "TI" },
    { id: 4, Nome: "Recursos Humanos" },
    { id: 5, Nome: "Marketing" },
];
function GrupoConsulta() {
    return (
        <Row>
            <TabelaGrupo ListaGrupo={ListaGrupo} />

        </Row>
    )
}
export default GrupoConsulta;