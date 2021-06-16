import config from 'config';
import { NextFunction, Response } from 'express';

import HttpException from '@exceptions/HttpException';
import { DataStoredInToken, RequestWithUser } from '@interfaces/auth.interface';
import userModel from '@models/users.model';
var jwt = require('jsonwebtoken');
var jwkToPem = require('jwk-to-pem');
var pem = jwkToPem(config.get('jwk'));


const authMiddleware = async (req: RequestWithUser, res: Response, next: NextFunction) => {
  try {
    const token = req.cookies['Authorization'] || req.header('Authorization').split('Bearer ')[1] || null;

    if (token) {
      jwt.verify(token, pem, { algorithms: ['RS256'] }, function (err, decodedToken) {
        if (err) {
          console.log(err);
          next(new HttpException(401, 'Wrong authentication token')); 
        }
        if (decodedToken) {
          console.log(decodedToken);
          next();
        }
      });

    }
  } catch (error) {
    next(new HttpException(401, 'Wrong authentication token'));
  }
};

export default authMiddleware;
