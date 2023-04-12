import React , { useState,useEffect }from 'react'
import {  Link } from 'react-router-dom';
import ProductCard from '../components/ProductCard';
import Container from '../components/Container';

const Home = () => {
  const [listProduct, setList] = useState([]);
  useEffect(()=>{
    
     const fetchData = async () => {
      const response = await fetch('https://localhost:7227/ProductService');
      const data = await response.json();
      setList(data)
    }    
     fetchData()
    // make sure to catch any error
    .catch(console.error);
}, [])

  return (
    <>
    <Container class1="home-wrapper-1 py-5">
    <div className="row">
            <div className="col-12">
              <div className="main-banner position-relative ">
                <img
                  src="images/Banner1.png"
                  className="img-fluid rounded-3 w-100"
                  alt="main banner"
                />
                <div className="main-banner-content position-absolute">
                  <h5>shirt for kids</h5>
                  <p>Starting at 199 bath</p>
                  <Link to="" className='button'>BUY NOW</Link>
                </div>
              </div>
            </div>
            
          </div>
    </Container>
    <Container class1="featured-wrapper py-5 home-wrapper-2">
    <div className='row'>
            <div className='col-12'>
              <h3 className='section-heading'>Featured Collection</h3>
            </div>
            {listProduct.map(product =>
              <ProductCard key={product.productID} name={product.name}
              price={product.price} id={product.productID} img ={product.image}/>
            )}           
    </div>
    </Container>
    </>
  );

};

export default Home