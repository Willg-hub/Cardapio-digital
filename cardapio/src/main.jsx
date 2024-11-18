import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import Header from './Components/Header.jsx'
import CardGrupo from './Components/Card.jsx';
import 'bootstrap/dist/css/bootstrap.min.css';

const comidas = [
    {
        nome: 'Pizza Margherita',
        descricao: 'Pizza cl�ssica com molho de tomate, mussarela de b�fala, manjeric�o fresco e azeite de oliva.',
        preco: 39.90
    },
    {
        nome: 'Hamb�rguer Artesanal',
        descricao: 'Hamb�rguer com carne de angus, queijo cheddar, alface, tomate e molho especial no p�o brioche.',
        preco: 29.90
    },
    {
        nome: 'Sushi Combo',
        descricao: 'Combo com 20 pe�as de sushi variado, incluindo nigiri, sashimi e uramaki.',
        preco: 59.90
    },
    {
        nome: 'Lasanha � Bolonhesa',
        descricao: 'Lasanha com camadas de massa fresca, molho bolonhesa, queijo parmes�o e molho bechamel.',
        preco: 49.90
    }
];

createRoot(document.getElementById('root')).render(
    <StrictMode>
        <Header />
        <CardGrupo produtos={comidas} />
    </StrictMode>,
);
