@import url('https://fonts.googleapis.com/css2?family=Montserrat:300,400,700&display=swap');
*{
    padding: 0;
    margin: 0;
    box-sizing: border-box;
}

html{
    font-size: 10px;
    font-family: 'Montserrat', san-serif;
    scroll-behavior: smooth;
}
a{
    text-decoration: none;
    color: inherit;
}
.container{
    min-height: 100vh;
    width: 100%;
    display: flex;
    align-items: center;
    justify-content: center;
}

img {
	height: 100%;
	width: 100%;
	object-fit: cover;
}
p{
    color: black;
    font-size: 1.4rem;
    margin-top: 5px;
    line-height: 2.5rem;
    font-weight: 300;
    letter-spacing: .05rem;
}
.section-tile{
    font-size: 4rem;
    font-weight: 300;
    color: black;
    margin-bottom:10px ;
    text-transform: uppercase;
    letter-spacing: .2rem;
    text-align: center;
}
.section-tile span {
    color: crimson;

}
.cta{
    display: inline-block;
    padding: 10px 30px;
    color: white;
    background-color: transparent;
    border: 2px solid crimson;
    font-size: 2rem;
    text-transform: uppercase;
    letter-spacing: .1rem;
    margin-top: 30px;
    transition: .3s ease;
    transition-property: background-color, color;
}
.cta:hover{
    color: white;
    background-color: crimson;
}
.brand h1{
    font-size: 3rem;
    text-transform: uppercase;
    color: white;
}
.brand h1 span{
    color: crimson;
}

/* Header Section */
#header{
    position: fixed;
    z-index: 1000;
    left: 0;
    top: 0;
    width: 100vw;
    height: auto;
}
#header .header{
    min-height: 8vh;
    background-color: rgba(31,30,30,0.24);
    transition: .3s ease background-color;
}
.header .nav-bar{
    display: flex;
    align-items: center;
    justify-content: space-between;
    width: 100%;
    height:100%;
    max-width: 1300px;
    padding: 0 10px;
}

#header .nav-list ul{
    list-style:none ;
    position: absolute;
    background-color: rgb(31,30,30);
    width: 100vw;
    height: 100vh;
    left: 100%;
    top: 0;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center ;
    z-index: 1;
    overflow: hidden;
    transition: .5 ease left;
}
#header .nav-list ul.active{
    left: 0%;
}
#header .nav-list ul a{
    font-size: 2.5rem;
    font-weight: 500;
    letter-spacing: .2rem;
    text-decoration: none;
    color: white;
    text-transform:uppercase ;
    padding: 20px;
    display: block;
}

#header .nav-list ul a::after{
    content: attr(data-after);
    position: absolute;
    top: 50%;
    left: 50%;
    transform: translate(-50%, -50%) scale(0);
    color: rgba(240, 248, 255, 0.021);
    font-size: 13rem;
    letter-spacing: 50px;
    z-index: -1;
    transition: .3s ease letter-spacing;

}
#header .nav-list ul li:hover a::after{
    transform: translate(-50%, -50%) scale(1);
    letter-spacing: initial;
}
#header .nav-list ul li:hover a{
    color:crimson;
}
#header .hamburger{
    height: 60px;
    width: 60px;
    display: inline-block;
    border: 3px solid white;
    border-radius: 50%;
    position:relative;
    display: flex;
    align-items: center;
    justify-content: center;
    z-index: 100;
    cursor: pointer;
    transform: scale(.8);
    margin-right: 20px;
}
#header .hamburger:after{
    position:absolute;
    content: '';
    height: 100%;
    width: 100%;
    border-radius: 50%;
    border: 3px solid white;
    animation: hamburger_puls 1s ease infinite;
}
#header .hamburger .bar{
    height: 2px;
    width: 30px;
    position: relative;
    background-color: white;
    z-index: -1;
}
#header .hamburger .bar::after,
#header .hamburger .bar::before{
    content:'';
    position: absolute;
    height: 100%;
    width: 100%;
    left: 0;
    background-color: white;
    transition: .3s ease;
    transition-property: top, bottom;
}
#header .hamburger .bar::after{
    top: 8px;
}
#header .hamburger .bar::before{
    bottom: 8px;
}
#header .hamburger.active .bar::before{
    bottom: 0;
}
#header .hamburger.active .bar::after{
    top: 0;
}
/* End header Section */

/* Hero Section */
#hero{
    background-image: url(./img/background.jpeg);
    background-size: cover;
    background-position: top center;
    position: relative;
    z-index: 1;
}
#hero::after{
    content:'';
    position: absolute;
    left: 0;
    top: 0;
    height:100%;
    width: 100%;
    background-color: black;
    opacity: .7;
    z-index: -1;
}
#hero .hero{
    max-width: 1200px;
    margin: 0 auto;
    padding:0 50px;
    justify-content: flex-start;
}
#hero h1{
    display: block;
    width: fit-content;
    font-size: 4rem;
    position: relative;
    color: transparent;
    animation: text_reveal .5s ease forwards;
    animation-delay: 1s;
}
#hero h1:nth-child(1) {
    animation-delay: 1s;
}
#hero h1:nth-child(2) {
    animation-delay: 2s;
}
#hero h1:nth-child(3) {
    animation: text_reveal_name .5s ease forwards;
    animation-delay: 3s;
}
#hero h1 span{
    position: absolute;
    top: 0;
    left: 0;
    height: 100%;
    width: 0;
    background-color: crimson;
    animation: text_reveal_box 1s ease;
    animation-delay: .5s;
}
#hero h1:nth-child(1) span{
    animation-delay: .5s;
}
#hero h1:nth-child(2) span{
    animation-delay: 1.5s;
}
#hero h1:nth-child(3) span{
    animation-delay: 2.5s;
}

/* End of Hero Section  */

/* Projects Section */
#projects .projects{
    flex-direction: column;
    max-width: 1200px;
    margin: 0 auto;
    padding: 100px 0;
}
#projects .project-header h1{
    margin-bottom: 50px;
}
#projects .all-projects{
    display: flex;
    align-items: center;
    justify-content: center;
    flex-direction: column;
}
#projects .project-item{
    display: flex;
    align-items: center;
    justify-content: center;
    flex-direction: column;
    width: 80%;
    margin: 20px auto;
    overflow: hidden;
    border-radius: 10px;
}
#projects .project-info{
    padding: 30px;
    flex-basis: 50%;
    height: 100%;
    display: flex;
    align-items: flex-start;
    justify-content: center;
    flex-direction: column;
    background-image: linear-gradient(60deg, #29323c 0%, #485563 100%);
    color: white;
}
#projects .project-info h1{
    font-size: 4rem;
    font-weight: 500;
}

#projects .project-info h2{
    font-size: 1.8rem;
    font-weight: 500;
    margin-top: 10px;
}
#projects .project-info p{
    color: white;
}
#projects .project-img{
    flex-basis: 50%;
    height: 500px;
    overflow: hidden;
    position: relative;
}
#projects .project-img:after{
    content: '';
    position: absolute;
    left: 0;
    top: 0;
    height: 100%;
    width: 100%;
    background-image: linear-gradient(60deg, #29323c 0%, #485563 100%) ;
    opacity: .7;
}
#projects .project-img img{
    transition: .3 ease transform;
}
#projects .project-item:hover .project-img img{
    transform: scale(1.1);
}
/* End of Projects Section */

/* About Section */
#about .about{
    flex-direction: column-reverse;
    text-align: center;
    max-width: 1200px;
    margin: 0 auto;
    padding: 100px 20px;
}
#about .col-left{
    width: 250px;
    height: 360px;
}
#about .col-right{
    width: 100%;
}
#about .col-right h2{
    font-size: 1.8rem;
    font-weight: 500;
    letter-spacing: .2rem;
    margin-bottom: 10px;
}

#about .col-right p{
    margin-bottom: 20px;
}
#about .col-right .cta{
    color: black;
    margin-bottom: 50px;
    padding: 10px 20px;
    font-size: 2rem; 
}
#about .col-left .about-img{
    height: 100%;
    width: 100%;
    position: relative;
    border: 10px solid white;
}
#about .col-left .about-img::after{
    content: '';
    position: absolute;
    left: -33px;
    top: 19px;
    height: 98%;
    width: 98%;
    border: 7px solid crimson;
    z-index: -1;
}
/* End of About Section */

/* Contact Section */
#contact .contact{
    flex-direction: column;
	max-width: 1200px;
	margin: 0 auto;
}

#contact .contact-items{
    width: 400px;
}
#contact .contact-item{
    width: 80%;
    padding: 20px;
    text-align: center;
    border-radius: 10px;
    padding: 30px;
    margin: 30px;
    display: flex;
    justify-content: center;
    align-items: center;
    box-shadow: 0px 0px 18px 0 #0000002c;
    flex-direction: column;
    transition: .3s ease box-shadow;
}
#contact .contact-item:hover{
    box-shadow: 0px 0px 5px 0 #0000002c;
}
#contact .icon{
    width: 70px;
    margin: 0 auto;
    margin-bottom: 10px;
}
#contact .contact-info h1{
    font-size: 2.5rem;
    font-weight: 500;
    margin-bottom: 5px;
}
#contact .contact-info h2{
    font-size: 1.3rem;
    line-height: 2rem;
    font-weight: 500;
}

/* End Contact Section */

/* Footer */
#footer {
    background-image:linear-gradient(60deg, #29323c 0%, #485563 100%);
}
#footer .footer{
    min-height: 200px;
    flex-direction: column;
    padding-top: 50px;
    padding-bottom: 10px;
}
#footer h2{
    color: white;
    font-weight: 500;
    font-size: 1.8rem;
    letter-spacing: .1rem;
    margin-top: 10px;
    margin-bottom: 10px;
}
#footer .social-icon{
    display: flex;
    margin-bottom: 30px;
}

#footer .social-item{
    height: 50px;
    width: 50px;
    margin: 0 5px;
}
#footer .social-item img{
    filter: grayscale(1);
    transition: .3s ease filter;
}
#footer .social-item:hover img{
    filter: grayscale(0)
}
#footer p{
    color: white;
    font-size: 1.3rem;
}
/* End Footer */

/* Keyframes */
@keyframes hamburger_puls{
    0%{
        opacity: 1;
        transform: scale(1);
    }
    100%{
        opacity: 0;
        transform: scale(1.4);
    }
}
@keyframes text_reveal_box{
    50%{
        width: 100%;
        left: 0 ;
    }
    100%{
        width: 0;
        left: 100%;
    }
}

@keyframes text_reveal{
    100%{
        color: white;
    }
}

@keyframes text_reveal_name{
    100%{
        color: crimson;
        font-weight: 500;
    }
}
/* End Keyframes */

/* Media Query For Tablet */
@media only screen and (min-width:768px){
    .cta{
        font-size: 2.5rem;
        padding: 20px 60px;
    }
    h1.section-tile{
        font-size: 6rem;
    }
    /* Hero */
    #hero h1{
        font-size: 7rem;
    }
    /* End Hero */

    /* Project Section */
    #projects .project-item{
        flex-direction: row;
    }
    #projects .project-item:nth-child(even){
        flex-direction: row-reverse;
    }
    #projects .project-item{
        height: 400px;
        margin: 0;
        width:100%;
        border-radius: 0;
    }
    #project .all-projects .project-info{
        height: 100%;
    }
    #project .all-projects .project-img{
        height: 100%;
    }
    /* End Project Section */

    /* About */
    #about .about{
        flex-direction: row;
    }
    #about .col-left{
        width: 600px;
        height: 400px;
        padding-left: 60px;
    }
    #about .about .col-left .about-img::after{
        left: -45px;
        top: 34px;
        height: 98%;
        width: 98%;
        border: 10px solid crimson;
    }
    #about .col-right{
        text-align: left;
        padding: 30px;
    }
    #about .col-right h1{
        text-align: left;
    }
    /* End About */

    /* Contact */
    #contact .contact{
        flex-direction: column;
        padding: 100px 0;
        align-items: center;
        justify-content: center;
        min-width: 20vh;
    }

    #contact .contact-items{
        width: 100%;
        display: flex;
        flex-direction: row;
        justify-content: space-evenly;
        margin: 0;
    }
    #contact .contact-item{
        margin: 30%;
        margin: 0;
        flex-direction: row;
    }
    #contact .contact-item .icon{
        height: 100px;
        width:100px;
    }
    #contact .contact-item .icon img{
        object-fit: contain;
    }
    #contact .contact-item .contact-info{
        width: 100%;
        text-align: left;
        padding-left: 20px;
    }

    /* End Contact */
}
/* End Media Query For Tablet */

/* Media Query for Desktop */
/* Header */
@media only screen and (min-width: 1200px){
    #header .hamburger{
        display: none;
    }
    #header .nav-list ul{
        position: initial;
        display: block;
        height: auto;
        width: fit-content;
        background-color: transparent;
    }
    #header .nav-list ul li{
        display: inline-block;
    }
    #header .nav-list ul li a{
        font-size: 1.8rem;
    }
}
/* End Header */
/* End media query for Desktop */
