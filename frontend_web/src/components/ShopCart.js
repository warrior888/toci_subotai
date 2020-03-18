import React, {Component} from 'react';
import {IoIosCart} from "react-icons/io";

export default class ShopCart extends Component {
    render() {
        return (
            <div>
                <IoIosCart size="2em" style={{
                    float: 'left',
                    color: 'white'
                }}/>
                <span style={{
                    float: 'right',
                    color: 'white'
                }}>Koszyk (2 produkty)</span>
            </div>
        );
    }

}
