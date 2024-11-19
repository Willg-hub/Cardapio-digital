import Header from '../Components/Header.jsx'
import CardGrupo from '../Components/Card.jsx'
import Row from 'react-bootstrap/Container';
const comidas = [
    {
        nome: 'Pizza Margherita',
        descricao: 'Pizza cl�ssica cona grelhada ganha ram osquempleta o lanche com sua cremosidade �nica. Uma combina��o perfeita de ingredientes frescos e saborosos que transforma cada mordida em uma experi�ncia deliciosa. Experimente agora nosso delicioso Fran�a Burguerlho de tomate, mussarela de b�fala, manjeric�o fresco e azeite de oliva.',
        preco: 39.90
    },
    {
        nome: 'Hamb�rguer Artesanal',
        descricao: 'Hamb�rguer com carne de angus, queijo cheddar, alface, tomate e molho especial no p�o brioche.',
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