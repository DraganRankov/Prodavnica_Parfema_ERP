import { Container, Paper, Typography, Divider, Button } from "@mui/material";
import { Link } from "react-router-dom";

export default function NotFound() {
    return (
        <Container component={Paper} style={{height: 400}}>
            <Typography gutterBottom variant={'h3'}>Ne možemo da nadjemo ono što tražite</Typography>
            <Divider />
            <Button component={Link} to='/catalog' fullWidth>Nazad u Katalog</Button>
        </Container>
    )
}