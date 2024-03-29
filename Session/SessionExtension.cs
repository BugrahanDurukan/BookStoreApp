﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace BugrahanDurukan_HW2.Session
{
	public static class SessionExtension
	{
		public static void Set<T>(this ISession session, string key, T value)
		{
			session.Set(key, JsonSerializer.Serialize(value));
		}
		public static T Get<T>(this ISession session, string key)
		{
			var value = session.Get(key);

			return value == null ? default(T) :
				JsonSerializer.Deserialize<T>(value);
		}
		public static void SetJson(this ISession session, string key, object value)
		{
			session.SetString(key, JsonSerializer.Serialize(value));
		}
		public static T GetJson<T>(this ISession session, string key)
		{
			var sessionData = session.GetString(key);
			return sessionData == null
			? default(T) : JsonSerializer.Deserialize<T>(sessionData);
		}

	}
}
