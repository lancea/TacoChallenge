import React, { Component } from 'react';

export class Home extends Component {
    static displayName = Home.name;

    render() {
        return (
            <div>
                <p>The endpoint for restaurants is at <a href="/api/restaurants">/api/restaurants</a></p>
                <p>I went down the wrong rabbit hole by trying to use EF with the sample dataset :/</p>                
            </div>
        );
    }
}