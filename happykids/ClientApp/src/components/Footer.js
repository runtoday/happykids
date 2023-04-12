import React from "react";
import { Link } from "react-router-dom";
import { BsLinkedin, BsGithub, BsYoutube, BsInstagram } from "react-icons/bs";

const Footer = () => {
  return (
    <>
      <footer className="py-4">
        <div className="container-xxl">
          <div className="row align-items-center">
            <a  className="text-white1 d-flex justify-content-center" href="text" > Back to top</a>

          </div>
        </div>
      </footer>
      <footer className="py-4">
        <div className="container-xxl">
          <div className="row">
            <div className="col-4">
              <h4 className="text-white1 mb-4"> Contact Us</h4>
              <div>
                <address className="text-white1 fs-5">
                   test , <br />  District, <br />  name  <br />
                  code
                </address>
                <a
                  href="tel: +66 12345678"
                  className="mt-3 d-block mb-3 text-white1"
                >
                  +66 12345678
                </a>
                <a
                  href="mailto: test@gmail.com"
                  className="mt-2 d-block mb-2 text-white1"
                >
                   test@gmail.com
                </a>
                <div className="social_icons d-flex align-items-center gap-30">
                  <a className="text-white1 " href="/">
                    <BsLinkedin className="fs-4" />
                  </a>
                  <a className="text-white1 " href="/">
                    <BsInstagram className="fs-4" />
                  </a>
                  <a className="text-white1 " href="/">
                    <BsGithub className="fs-4" />
                  </a>
                  <a className="text-white1 " href="/">
                    <BsYoutube className="fs-4" />
                  </a>
                </div>
              </div>
            </div>
            <div className="col-3">
              <h4 className="text-white1 mb-4">Informatlon</h4>
              <div className="footer-links d-flex flex-column">
                <Link to='/privacy-policy' className="text-white1 py-2 mb-1">Privacy Policy</Link>
                <Link to='/refund-policy' className="text-white1 py-2 mb-1">Refund Policy</Link>
                <Link to='/shipping-policy' className="text-white1 py-2 mb-1">Shipping Policy</Link>
                <Link to='/term-conditions' className="text-white1 py-2 mb-1">Terms & Conditions</Link>
                <Link className="text-white1 py-2 mb-1">Blogs</Link>
              </div>
            </div>
            <div className="col-3">
              <h4 className="text-white1 mb-4">Account</h4>
              <div className="footer-links d-flex flex-column">
                <Link className="text-white1 py-2 mb-1">About Us</Link>
                <Link className="text-white1 py-2 mb-1">Faq</Link>
                <Link className="text-white1 py-2 mb-1">Contact</Link>
              </div>
            </div>
            <div className="col-2">
              <h4 className="text-white1 mb-4">Qulck Links</h4>
              <div className="footer-links d-flex flex-column">
                <Link className="text-white1 py-2 mb-1">shirt</Link>
                <Link className="text-white1 py-2 mb-1">body suite</Link>
              </div>
            </div>
          </div>
        </div>
      </footer>
      <footer className="py-4">
        <div className="container-xxl">
          <div className="row">
            <div className="col-12">
            </div>
          </div>
        </div>
      </footer>
    </>
  );
};

export default Footer;
