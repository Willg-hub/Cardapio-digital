import Header from '../Components/Header.jsx'
import CardGrupo from '../Components/Card.jsx'
import Row from 'react-bootstrap/Container';
const comidas = [
    {
        nome: 'Pizza Margherita',
        descricao: 'Pizza clássica cona grelhada ganha ram osquempleta o lanche com sua cremosidade única. Uma combinação perfeita de ingredientes frescos e saborosos que transforma cada mordida em uma experiência deliciosa. Experimente agora nosso delicioso França Burguerlho de tomate, mussarela de búfala, manjericão fresco e azeite de oliva.',
        preco: 39.90
    },
    {
        nome: 'Hambúrguer Artesanal',
        descricao: 'Hambúrguer com carne de angus, queijo cheddar, alface, tomate e molho especial no pão brioche.',
        preco: 29.90
    }
];
function Home() {
    return (

            <Row>
                <Header />
                <CardGrupo produtos={comidas} />
            </Row>

    )
}

export default Home