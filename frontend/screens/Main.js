import React, {Component} from 'react';
import {StyleSheet, StatusBar} from 'react-native';
import {changeNavigationBarColor} from 'react-native-navigation-bar-color/src';
import {createBottomTabNavigator} from '@react-navigation/bottom-tabs';
import Icon from 'react-native-vector-icons/Ionicons';

import ProductOfDay from '../views/ProductOfDay';
import Home from '../views/Home';
import ShopCard from '../views/ShopCard';

const Tab = createBottomTabNavigator();

export default class Main extends Component {
  componentDidMount() {
    changeNavigationBarColor('#915e8d', false);
  }

  render() {
    return (
      <>
        <StatusBar backgroundColor="#915e8d" barStyle="light-content" />
        <Tab.Navigator
          screenOptions={({route}) => ({
            tabBarIcon: ({focused, color, size}) => {
              let icon;
              switch (route.name) {
                case 'ProductOfDay':
                  icon = 'md-star';
                  break;
                case 'ShopCard':
                  icon = 'md-basket';
                  break;
                case 'Home':
                  icon = 'md-home';
                  break;
              }
              return <Icon name={icon} size={size} color={color} />;
            },
          })}
          tabBarOptions={{
            showLabel: false,
            activeTintColor: 'white',
            inactiveTintColor: '#95a5a6',
            style: styles.navigation,
          }}>
          <Tab.Screen name="ProductOfDay" component={ProductOfDay} />
          <Tab.Screen name="Home" component={Home} />
          <Tab.Screen
            name="ShopCard"
            component={ShopCard}
          />
        </Tab.Navigator>
      </>
    );
  }
}

const styles = StyleSheet.create({
  main: {
    height: '100%',
    backgroundColor: '#fff',
  },
  navigation: {
    backgroundColor: '#915e8d',
  },
});
