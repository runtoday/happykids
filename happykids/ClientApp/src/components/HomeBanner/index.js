/*
 ** Author: Santosh Kumar Dash
 ** Author URL: http://santoshdash.epizy.com/
 ** Github URL: https://github.com/quintuslabs/fashion-cube
 */

import React from "react";

import BackgroundImage1 from "../../assets/images/banner1.png";
import BackgroundImage2 from "../../assets/images/banner2.png";
import BackgroundImage3 from "../../assets/images/banner3.png";
import { Carousel } from "react-bootstrap";

function HomeBanner(props) {
  return (
    <Carousel>
      <Carousel.Item>
        <div
          className="d-block w-100 main_slider"
          style={{
            backgroundImage: `url(${BackgroundImage1})  `,
            backgroundPosition: 'center',
            backgroundSize: 'cover',
            backgroundRepeat: 'no-repeat',
            width: '80vw',
            height: '80vh'
          }
        }
        >
        </div>
      </Carousel.Item>
      <Carousel.Item>
        <div
          className="d-block w-100 main_slider"
          style={{
            backgroundImage: `url(${BackgroundImage2})  `,
            backgroundPosition: 'center',
            backgroundSize: 'cover',
            backgroundRepeat: 'no-repeat',
            width: '80vw',
            height: '80vh'
          }
        }
        >
        </div>
      </Carousel.Item>
      <Carousel.Item>
        <div
          className="d-block w-100 main_slider"
          style={{
            backgroundImage: `url(${BackgroundImage3})  `,
            backgroundPosition: 'center',
            backgroundSize: 'cover',
            backgroundRepeat: 'no-repeat',
            width: '80vw',
            height: '80vh'
          }
        }
        >
          <div className="container center">
            <div className="row align-items-center center">
              <div className="col">
                <div className="main_slider_content" data-style="center">
                  <h6>Spring / Summer Collection 2017</h6>
                  <h1>Get up to 30% Off New Arrivals</h1>
                  <div className="red_button shop_now_button">
                    <a href="#">shop now</a>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </Carousel.Item>
    </Carousel>
  );
}

export default HomeBanner;
