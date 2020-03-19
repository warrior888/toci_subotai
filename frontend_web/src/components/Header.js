import React, {Component} from 'react';
import {StyleSheet, css} from 'aphrodite';
import {Link} from 'react-router-dom';
import { IoLogoFacebook, IoLogoInstagram, IoIosMail, IoIosCall } from 'react-icons/io';
import ShopCart from "./ShopCart";

export default class Header extends Component {
    render() {
        return (
            <div className={css(styles.main)}>
                <div style={{
                    float: 'left',
                    paddingLeft: '100px'
                }}>
                    <IoLogoFacebook size="2em" className={css(styles.icon)} style={{marginRight: '5px'}}/>
                    <IoLogoInstagram size="2em" className={css(styles.icon)}/>
                </div>
                <div style={{
                    marginLeft: '50px',
                    float: 'left',
                }}>
                    <IoIosMail size="2em" className={css(styles.icon)}/>
                    <span style={{
                        color: 'white',
                    }}>adres@gmail.com</span>
                </div>
                <div style={{
                    float: 'left',
                }}>
                    <IoIosCall size="2em" className={css(styles.icon)}/>
                    <span style={{
                        color: 'white',
                        textAlign: 'center'
                    }}>+48 123 123 123</span>
                </div>
                <div style={{
                    float: 'right',
                    paddingRight: '100px'
                }}>
                    <div style={{
                        float: 'left'
                    }}>
                        <Link className={css(styles.link)} to="/">Logowanie</Link>
                        <span style={{color: 'white'}}>/</span>
                        <Link className={css(styles.link)} to="/">Rejestracja</Link>
                    </div>
                    <div style={{
                        float: 'right'
                    }}>
                        <ShopCart />
                    </div>
                </div>
            </div>
        )
    }

}

const styles = StyleSheet.create({
    main: {
        height: '50px',
        weight: '100%',
        backgroundColor: '#925e8e',
    },
    icon: {
        color: 'white',
        paddingTop: '10px',
    },
    link: {
        color: 'white',
        textDecoration: 'none'
    }
});
