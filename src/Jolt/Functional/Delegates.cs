﻿// ----------------------------------------------------------------------------
// Delegates.cs
//
// Contains the definition of the Action and Func delegates.
// Copyright 2009 Steve Guidi.
//
// File created: 3/16/2009 18:07:41
// ----------------------------------------------------------------------------

namespace Jolt.Functional
{
    /// <summary>
    /// Encapsulates a method that has five parameters and does not return a value.
    /// </summary>
    /// 
    /// <typeparam name="T1">
    /// The type of the first parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T2">
    /// The type of the second parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T3">
    /// The type of the third parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T4">
    /// The type of the fourth parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T5">
    /// The type of the fifth parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <param name="arg1">
    /// The first parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg2">
    /// The second parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg3">
    /// The third parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg4">
    /// The fourth parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg5">
    /// The fifth parameter of the method that this delegate encapsulates.
    /// </param>
    public delegate void Action<T1, T2, T3, T4, T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);

    /// <summary>
    /// Encapsulates a method that has six parameters and does not return a value.
    /// </summary>
    /// 
    /// <typeparam name="T1">
    /// The type of the first parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T2">
    /// The type of the second parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T3">
    /// The type of the third parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T4">
    /// The type of the fourth parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T5">
    /// The type of the fifth parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T6">
    /// The type of the sixth parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <param name="arg1">
    /// The first parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg2">
    /// The second parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg3">
    /// The third parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg4">
    /// The fourth parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg5">
    /// The fifth parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg6">
    /// The sixth parameter of the method that this delegate encapsulates.
    /// </param>
    public delegate void Action<T1, T2, T3, T4, T5, T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);

    /// <summary>
    /// Encapsulates a method that has seven parameters and does not return a value.
    /// </summary>
    /// 
    /// <typeparam name="T1">
    /// The type of the first parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T2">
    /// The type of the second parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T3">
    /// The type of the third parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T4">
    /// The type of the fourth parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T5">
    /// The type of the fifth parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T6">
    /// The type of the sixth parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T7">
    /// The type of the seventh parameter of the method that this delegate encapsulates.
    /// </typeparam>
    ///
    /// <param name="arg1">
    /// The first parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg2">
    /// The second parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg3">
    /// The third parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg4">
    /// The fourth parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg5">
    /// The fifth parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg6">
    /// The sixth parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg7">
    /// The seventh parameter of the method that this delegate encapsulates.
    /// </param>
    public delegate void Action<T1, T2, T3, T4, T5, T6, T7>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);

    /// <summary>
    /// Encapsulates a method that has five parameters and returns a value
    /// of the type specified by the <typeparamref name="TResult"/> parameter.
    /// </summary>
    /// 
    /// <typeparam name="TResult">
    /// The type of the return value encapsulated by this delegate..
    /// </typeparam>
    /// 
    /// <typeparam name="T1">
    /// The type of the first parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T2">
    /// The type of the second parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T3">
    /// The type of the third parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T4">
    /// The type of the fourth parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T5">
    /// The type of the fifth parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <param name="arg1">
    /// The first parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg2">
    /// The second parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg3">
    /// The third parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg4">
    /// The fourth parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg5">
    /// The fifth parameter of the method that this delegate encapsulates.
    /// </param>
    public delegate TResult Func<T1, T2, T3, T4, T5, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);

    /// <summary>
    /// Encapsulates a method that has six parameters and returns a value
    /// of the type specified by the <typeparamref name="TResult" /> parameter.
    /// </summary>
    /// 
    /// <typeparam name="TResult">
    /// The type of the return value encapsulated by this delegate..
    /// </typeparam>
    /// 
    /// <typeparam name="T1">
    /// The type of the first parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T2">
    /// The type of the second parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T3">
    /// The type of the third parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T4">
    /// The type of the fourth parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T5">
    /// The type of the fifth parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T6">
    /// The type of the sixth parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <param name="arg1">
    /// The first parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg2">
    /// The second parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg3">
    /// The third parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg4">
    /// The fourth parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg5">
    /// The fifth parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg6">
    /// The sixth parameter of the method that this delegate encapsulates.
    /// </param>
    public delegate TResult Func<T1, T2, T3, T4, T5, T6, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);

    /// <summary>
    /// Encapsulates a method that has seven parameters and returns a value
    /// of the type specified by the <typeparamref name="TResult" /> parameter.
    /// </summary>
    /// 
    /// <typeparam name="TResult">
    /// The type of the return value encapsulated by this delegate..
    /// </typeparam>
    /// 
    /// <typeparam name="T1">
    /// The type of the first parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T2">
    /// The type of the second parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T3">
    /// The type of the third parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T4">
    /// The type of the fourth parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T5">
    /// The type of the fifth parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T6">
    /// The type of the sixth parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <typeparam name="T7">
    /// The type of the seventh parameter of the method that this delegate encapsulates.
    /// </typeparam>
    /// 
    /// <param name="arg1">
    /// The first parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg2">
    /// The second parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg3">
    /// The third parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg4">
    /// The fourth parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg5">
    /// The fifth parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg6">
    /// The sixth parameter of the method that this delegate encapsulates.
    /// </param>
    /// 
    /// <param name="arg7">
    /// The seventh parameter of the method that this delegate encapsulates.
    /// </param>
    public delegate TResult Func<T1, T2, T3, T4, T5, T6, T7, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);
}