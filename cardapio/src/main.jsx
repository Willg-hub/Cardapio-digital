import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import Header from './Components/Header.jsx'
import CardGrupo from './Components/Card.jsx';
import 'bootstrap/dist/css/bootstrap.min.css';

const comidas = [
    {
        nome: 'Pizza Margherita',
        descricao: 'Pizza clássica com molho de tomate, mussarela de búfala, manjericão fresco e azeite de oliva.',
        preco: 39.90
    },
    {
        nome: 'Hambúrguer Artesanal',
        descricao: 'Hambúrguer com carne de angus, queijo cheddar, alface, tomate e molho especial no pão brioche.',
        preco: 29.90
    },
    {
        nome: 'Sushi Combo',
        descricao: 'Combo com 20 peças de sushi variado, incluindo nigiri, sashimi e uramaki.',
        preco: 59.90
    },
    {
        nome: 'Lasanha à Bolonhesa',
        descricao: 'Lasanha com camadas de massa fresca, molho bolonhesa, queijo parmesão e molho bechamel.',
        preco: 49.90
    }
];

createRoot(document.getElementById('root')).render(
    <StrictMode>
        <Header />
        <CardGrupo produtos={comidas} />
    </StrictMode>,
);
