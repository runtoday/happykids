import React from 'react'
import BreadCrumb from "../components/BreadCrumb";
import Meta from "../components/Meta";
import Container from '../components/Container';
const Wishist = () => {
  return (
    <>
     <Meta title={"wishist"} />
      <BreadCrumb title="wishist" />
      <Container class1='wishist-wrapper home-wrapper-2 py-5'>
            <div className='row'>
            </div>
      </Container>
    
    
    </>
  )
}

export default Wishist