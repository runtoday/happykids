import React from 'react'
import BreadCrumb from "../components/BreadCrumb";
import { AiOutlineHome } from 'react-icons/ai';
import { BiPhoneCall } from 'react-icons/bi';
import { CiMail } from 'react-icons/ci';
import {BsInfoCircle} from 'react-icons/bs';
import Meta from "../components/Meta";
import Container from '../components/Container';
const Contact = () => {
  return (
    <>
      <Meta title={"Contact Us"} />
      <BreadCrumb title="Contact Us" />
      <Container class1="contact-wrapper py-5 home-wrapper-2">
      </Container>

    </>
  );
  
};

export default Contact;