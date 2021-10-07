import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Directions } from './components/directions';
import { Copyright } from './components/copyright';
import { PageControl } from './components/PageControl';
import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/copyright' component={Copyright} />
        <Route path='/directions' component={Directions} />
        <Route path='/pageControl' component={PageControl} />
      </Layout>
    );
  }
}
