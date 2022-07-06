import React from 'react';
import ReactDOM from 'react-dom';
import reportWebVitals from './reportWebVitals';
import './index.css';
import Login from './pages/Login/Login';
import Cadastro from './pages/Cadastro/Cadastro'
import NotFound from './pages/NotFound/NotFound';


import {
  Route,
  BrowserRouter as Router,

} from 'react-router-dom';
import { Switch } from 'react-router-dom';



const routing = (
  <Router>
    <div>
      <Switch>
        <Route exact path="/login" component={props => <Login {...props} />} />
        <Route path="/cadastro" component={Cadastro} />

       
        <Route exact path="/" component={Login} />
        

        

        
        <Route path="/cadastro" component={Cadastro} />

        <Route path="*" component={props => <NotFound {...props} />} />

      </Switch>
    </div>
  </Router>
)

ReactDOM.render(
  routing,
  document.getElementById('root')
);

reportWebVitals();
