import React, { Component } from 'react';
import { Route, Routes } from 'react-router-dom';
import {useLocation } from 'react-router-dom';
import AppRoutes from './AppRoutes';
import { Layout } from './components/Layout';
import './custom.css';

export default class App extends Component {
  static displayName = App.name;
  

  render() {
    return (
      <Layout>
        <Routes>
          {AppRoutes.map((route, index) => {
            const { element, ...rest } = route;
            //console.log(route);
            //console.log(index);
            //console.log(rest);
            //const location = useLocation();
            //console.log(location, " props");
            return <Route key={index} {...rest} element={element}/>;
          })}
        </Routes>
      </Layout>
    );
  }
}
