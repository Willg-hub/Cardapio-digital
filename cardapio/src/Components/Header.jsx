import styles from '../css/Nav.module.css'
import Container from 'react-bootstrap/Container';
import Navbar from 'react-bootstrap/Navbar';
import img from "../assets/a.png"
function Header() {
    return (
        <>
            <Navbar className={`${styles.nav} bg-dark col-md-9 mx-auto`}>
                <Container >
                    <Navbar.Brand className={`${styles.navContent} mx-auto`}>
                        <img
                            alt="[Imagem da empresa]"
                            src={img}
                            width="150"
                            height="150"
                            className=""
                        />
                        <h1 className={styles.titulo}>[Nome da empresa]</h1>
                    </Navbar.Brand>
                </Container>
            </Navbar>
        </>
    );
}

export default Header