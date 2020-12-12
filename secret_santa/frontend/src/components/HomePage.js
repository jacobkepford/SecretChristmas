import React, { Component} from 'react';
import PartyJoinPage from "./PartyJoinPage";
import CreatePartyPage from "./CreatePartyPage";
import {BrowserRouter as Router, Switch, Route, Link, Redirect} from "react-router-dom";

export default class HomePage extends Component {
    constructor(props){
        super(props);
    }

    render(){
        return (<Router>
            <Switch>
                <Route exact path='/' ><p>This is the homepage</p></Route>
                <Route path='/join' component={PartyJoinPage} />
                <Route path='/create' component={CreatePartyPage} />
            </Switch>
        </Router>
        );
    }
}