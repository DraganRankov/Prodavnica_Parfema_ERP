import { Box, Typography } from "@mui/material";
import Slider from 'react-slick';

export default function HomePage() {
    const settings = {
        dots: true,
        infinite: true,
        speed: 500,
        slidesToShow: 1,
        slidesToScroll: 1
    };

    return (
        <>
            <Slider {...settings}>
                <div>
                    <img src="/images/perfemska soba glavni.jpg" alt="hero" style={{ display: 'block', width: '100%', maxHeight:770 }} />
                </div>
                <div>
                    <img src="/images/IMG_7554.jpg" alt="hero" style={{ display: 'block', width: '100%', maxHeight: 770 }} />
                </div>
                <div>
                    <img src="/images/IMG_7337.jpg" alt="hero" style={{ display: 'block', width: '100%', maxHeight: 770 }} />
                </div>
            </Slider>
            <Box display='flex' justifyContent='center' sx={{ p: 4 }} >
                <Typography variant='h1'>
                    Dobrodošli u prodavnicu parfema!
                </Typography>
            </Box>
        </>
    )
}