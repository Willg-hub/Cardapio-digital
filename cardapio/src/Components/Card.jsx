import Card from 'react-bootstrap/Card';
import Figure from 'react-bootstrap/Figure';
import styles from '../css/Card.module.css';
import img from "../assets/a.png";
function CardGrupo() {
    return (
        <Card className="col-12 col-md-9 mx-auto mt-3">
            <Card.Header as="h2" className={`${styles.cardTitulo} text-center`}>[Nome do grupo]</Card.Header>
            <Card.Body className={styles.cardProduto}>
                <div className={`${styles.decricaoProduto} col-7 col-md-9`}>
                    <Card.Title>[Nome do produto]</Card.Title>
                    <Card.Text>
                        [asdffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffasdffffffffffffffffffffffffffffffffasdffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffasdffffffffffffffffffffffffffffffffasdffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffasdffffffffffffffffffffffffffffffffasdffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffasdffffffffffffffffffffffffffffffff]
                    </Card.Text>
                    <Card.Title>Por: R$00,00</Card.Title>
                </div>
                <Figure className={`${styles.figure}`}>
                    <Figure.Image className={styles.imagemProduto}

                        src={img}
                    />
                </Figure>
            </Card.Body>
            <Card.Body className={styles.cardProduto}>
                <div className={`${styles.decricaoProduto} col-7 col-md-9`}>
                    <Card.Title>[Nome do produto]</Card.Title>
                    <Card.Text>
                        [asdffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffasdffffffffffffffffffffffffffffffffasdffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffasdffffffffffffffffffffffffffffffffasdffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffasdffffffffffffffffffffffffffffffffasdffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffasdffffffffffffffffffffffffffffffff]
                    </Card.Text>
                    <Card.Title>Por: R$00,00</Card.Title>
                </div>
                <Figure className={`${styles.figure}`}>
                    <Figure.Image className={styles.imagemProduto}

                        src={img}
                    />
                </Figure>
            </Card.Body>
            <Card.Body className={styles.cardProduto}>
                <div className={`${styles.decricaoProduto} col-7 col-md-9`}>
                    <Card.Title>[Nome do produto]</Card.Title>
                    <Card.Text>
                        [asdffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffasdffffffffffffffffffffffffffffffffasdffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffasdffffffffffffffffffffffffffffffffasdffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffasdffffffffffffffffffffffffffffffffasdffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffasdffffffffffffffffffffffffffffffff]
                    </Card.Text>
                    <Card.Title>Por: R$00,00</Card.Title>
                </div>
                <Figure className={`${styles.figure}`}>
                    <Figure.Image className={styles.imagemProduto}

                        src={img}
                    />
                </Figure>
            </Card.Body>
        </Card>
    );
}

export default CardGrupo;