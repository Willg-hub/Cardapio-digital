import Card from 'react-bootstrap/Card';
import Figure from 'react-bootstrap/Figure';
import styles from '../css/Card.module.css';
import img from "../assets/a.png";
function CardGrupo({ produtos }) {
    return (
        <Card className=" col-md-9 mx-auto mt-3 p-0 bg-white">
            <Card.Header as="h2" className={`${styles.cardTitulo} text-center`}>[Nome do grupo]</Card.Header>
            {produtos.map((produto, index) => (

                <Card.Body className={styles.cardProduto}>

                    <div className={`${styles.decricaoProduto} col-7 col-md-9`}>
                        <Card.Title>{produto.nome}</Card.Title>
                        <Card.Text>
                            {produto.descricao}
                        </Card.Text>
                        <Card.Title>{produto.preco}</Card.Title>
                    </div>
                    <Figure className={`${styles.figure}`}>
                        <Figure.Image className={styles.imagemProduto}

                            src={img}
                        />
                    </Figure>


                </Card.Body>
            ))}
        </Card>
    );
}

export default CardGrupo;